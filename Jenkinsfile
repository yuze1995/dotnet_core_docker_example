pipeline {
  agent any
  stages {
    stage('git checkout') {
      steps {
        git(url: 'https://github.com/yuze1995/dotnet_core_docker_example.git', branch: 'master')
      }
    }

    stage('unit test') {
      steps {
        sh 'dotnet restore'
        sh 'dotnet test'
      }
    }

    stage('Sonar') {
      def sqScannerMsBuildHome = tool 'SonarScanner-Core-2.0'
      withSonarQubeEnv('dotnet_core_docker_example') {
        sh "${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe begin /k:dotnet_core_docker_example"
        sh 'dotnet build'
        sh "${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe end"
      }
    }
  }
}