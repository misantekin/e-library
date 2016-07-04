angular.module("publishers", [])
  .controller("PublishersCtrl", ["$scope", "$http", function ($scope, $http) {
      $scope.publishers = {};
      $http.get(serviceBase + "api/publisher").success(function (response) {
          $scope.publishers = response;
      });
  }]);