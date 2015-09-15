angular.module("categoriaController", ["Service"]).controller(
    "catlistController", ["$scope", "$location", "remoteResources",
        function ($scope, $location, remoteResources) {

            $scope.url = "http://localhost:53480/api/Categoria/ObtenerTodos";
            $scope.categorias = [];

            remoteResources.list($scope.url).then(function (categorias) {
                $scope.categorias = categorias;
            });

        }
    ]);