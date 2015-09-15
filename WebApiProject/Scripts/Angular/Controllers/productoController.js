angular.module("productoController", ["Service"]).controller(
    "prodlistController", ["$scope", "$location", "remoteResources",
        function ($scope, $location, remoteResources) {

            $scope.url = "http://localhost:53480/api/Producto/ObtenerTodos";
            $scope.productos = [];

            remoteResources.list($scope.url).then(function (productos) {                
                $scope.productos = productos;
            });

        }
    ]);