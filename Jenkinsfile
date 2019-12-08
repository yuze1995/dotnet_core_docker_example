pipeline {
  agent any
  stages {
    stage('git checkout') {
      steps {
        git(url: 'https://github.com/yuze1995/dotnet_core_docker_example.git', branch: 'master')
      }
    }

    // stage('unit test') {
    //   steps {
    //     sh 'dotnet test'
    //   }
    // }

    stage('Sonar') {
      environment {
        sqScannerMsBuildHome = tool 'SonarScanner-Core-2.0'
      }
      steps {
        sh "${sqScannerMsBuildHome}/SonarScanner.MSBuild.dll begin /k:dotnet_core_docker_example"
        sh 'dotnet build'
        sh "${sqScannerMsBuildHome}/SonarScanner.MSBuild.dll end"
      }
    }
  }
}