angular.module("categoriaController", ["Service"]).controller(
    "catlistController", ["$scope", "$location", "remoteResources",
        function ($scope, $location, remoteResources) {

            //$scope.url = "http://localhost:53480/Scripts/json/categorias.json";
            $scope.categorias = [
	                                {
	                                    id: 1,
	                                    nombre: "Gaseosas"
	                                },
	                                {
	                                    id: 2,
	                                    nombre: "Comestibles"
	                                },
	                                {
	                                    id: 3,
	                                    nombre: "Cosas"
	                                },
	                                {
	                                    id: 4,
	                                    nombre: "Otras"
	                                }
            ];

            //remoteResources.list($scope.url).then(function (categorias) {
            //    $scope.categorias = categorias;
            //});

        }
    ]);