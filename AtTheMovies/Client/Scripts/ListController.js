(function (app) {

    var ListController = function ($scope, $http) {

        $http.get("/api/movie")
            .success(function (data) {
                $scope.movies = data;
            });
    };

    //ListController.$inject = [$scope, $http];

    app.controller("ListController", ListController);

}(angular.module("atTheMovies")));