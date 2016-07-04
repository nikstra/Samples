(function (app) {

    var DetailsController = function ($scope, $routeParams, movieService) {

        var id = $routeParams.id;
        movieService
            .getById(id)
            .success(function (data) {
                $scope.movie = data;
            });
    };

    app.controller("DetailsController", DetailsController);

}(angular.module("atTheMovies")));