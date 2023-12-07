using namespace System.Reflection;

function global:Import-Project {

    [CmdletBinding(DefaultParameterSetName="individual")]param(
        [Parameter(Mandatory, ValueFromPipeline, ParameterSetName = "individual", Position = 0)]
        [string]$ProjectName,

        [Parameter(Mandatory, ParameterSetName = "collective", Position = 0)]
        [string[]]$ProjectNames
    )

    switch ($PSCmdlet.ParameterSetName) {
        'individual' {
            $assemblyPath = "$PSScriptRoot\$ProjectName\bin\release\net8.0\$ProjectName.dll";
            Write-Verbose "Importando: $assemblyPath";
            add-type -path $assemblyPath;
        }

        'collective' {
            foreach ($ProjectName in $ProjectNames) {
                Import-Project $ProjectName -Verbose;
            }
        }
    }
}

function global:Get-Assembly {

    [CmdletBinding(DefaultParameterSetName="individual")] param(
        [Parameter(Mandatory,Position=0,ParameterSetName="individual")][string]$AssemblyName,
        [Parameter(Mandatory,Position=0,ParameterSetName="collective")][switch]$All
    )

    switch($PSCmdlet.ParameterSetName) {
        "individual" {
            [Assembly[]]$assemblies = Get-Assembly -All;
            foreach($assembly in $assemblies) {
                [string]$iteratedName = $assembly.GetName().Name.ToLower();
                [string]$searchedName = $AssemblyName.ToLower();
                if($iteratedName -eq $searchedName) {
                    return $assembly;
                }
            }
        }
        "collective" {
            [AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {!$_.IsDynamic};
        }
    }
}

enum TypeMatchingCriteria {
    Equal
    Contain
    Start
    Finish
}

function global:Get-Type {

    [CmdletBinding()]param(
        [Parameter(Mandatory,Position=0,ParameterSetName="namespace")]
        [string]$Namespace,

        [Parameter(Position=1,ParameterSetName="namespace")]
        [TypeMatchingCriteria]$MatchingCriteria = "Start"
    )

    [Type[]]$types = Get-Assemblies | ForEach-Object {$_.ExportedTypes};

    switch($PSCmdlet.ParameterSetName) {
        'namespace' {
            switch($MatchingCriteria) {
                'Equal' {
                    foreach ($type in $types) {
                        if($type.Namespace.ToLower().Equals($Namespace.ToLower())) {
                            $type
                        }
                    }
                }
                'Contain' {
                    foreach ($type in $types) {
                        if($type.Namespace.ToLower().Contains($Namespace.ToLower())) {
                            $type;
                        }
                    }
                }
                'Start' {
                    foreach ($type in $types) {
                        if($type.Namespace.ToLower().StartsWith($Namespace.ToLower())) {
                            $type;
                        }
                    }
                }
                'Finish' {
                    foreach ($type in $types) {
                        if($type.Namespace.ToLower().EndsWith($Namespace.ToLower())) {
                            $type
                        }
                    }
                }
            }
        }
    }
}