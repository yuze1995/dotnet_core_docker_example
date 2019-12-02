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
        sh '''dotnet restore
dotnet test'''
      }
    }

  }
}