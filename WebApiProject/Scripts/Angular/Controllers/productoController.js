angular.module("productoController", ["Service"]).controller(
    "prodlistController", ["$scope", "$location", "remoteResources",
        function ($scope, $location, remoteResources) {

            //$scope.url = "http://localhost:53480/Scripts/json/productos.json";
            $scope.productos = [
	                                {
	                                    id: 1,
	                                    nombre: "Coca",
	                                    precio: 2,
	                                    descripcion: "Pruebassssssssss"
	                                },
	                                {
	                                    id: 2,
	                                    nombre: "Fanta",
	                                    precio: 3,
	                                    descripcion: "Pruebassssssssss"
	                                },
	                                {
	                                    id: 3,
	                                    nombre: "Alfajor",
	                                    precio: 2,
	                                    descripcion: "Pruebassssssssss"
	                                },
	                                {
	                                    id: 4,
	                                    nombre: "Lavandina",
	                                    precio: 2,
	                                    descripcion: "Pruebassssssssss"
	                                }];

            //remoteResources.list($scope.url).then(function (productos) {                
            //    $scope.productos = productos;
            //});

        }
    ]);