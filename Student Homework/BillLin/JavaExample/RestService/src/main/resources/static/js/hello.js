function Hello($scope, $http) {
    $http.get('http://localhost:9080/greeting').
        success(function(data) {
            $scope.greeting = data;
        });
}
