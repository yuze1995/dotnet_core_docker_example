pipeline {
  agent any
  stages {
    stage('git checkout') {
      steps {
        git(url: 'https://github.com/yuze1995/dotnet_core_docker_example.git', branch: 'master')
      }
    }

    stage('test 1') {
      when { tag "test-*" }
      steps {
        sh 'echo tag "test-*"'
      }
    }
    
    stage('test 2') {
      when { tag "release-*" }
      steps {
        sh 'echo tag whatever'
      }
    }

    // stage('sonar analysis') {
    //   steps {
    //     sh 'dotnet sonarscanner begin /k:dotnet_core_docker_example' +
    //        ' /d:sonar.host.url=http://192.168.233.134:9000' +
    //        ' /d:sonar.cs.opencover.reportsPaths=coverage.opencover.xml'
    //     sh 'dotnet build DotNetCoreDockerExample.sln'
    //     sh 'dotnet-sonarscanner end'
    //   }
    // }
  }
}