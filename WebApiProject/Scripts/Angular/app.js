angular.module("app", ['ngRoute', 'productoController','categoriaController']).config(['$routeProvider', function ($routeProvider) {

    /*bloque de Producto */

    $routeProvider.when('/producto/list', {
        templateUrl: "../../Views/Home/Index.cshtml",
        controller: "listController"
    });   

    $routeProvider.otherwise({
        redirectTo: '/producto/list'
    });

}]);