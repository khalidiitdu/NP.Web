$.noConflict();

var myApp = angular.module('myApp', ['ngRoute']);

function RouteConfig($routeProvider) {
    $routeProvider
        .when("/Home/About/", { templateUrl: "/Home/About/", controller: HomeController })
        .when("/Administrator/Admin/Role/", { templateUrl: "/Administrator/Admin/Role/", controller: RoleController })
        .when("/Administrator/Admin/RoleList/", { templateUrl: "/Administrator/Admin/RoleList/", controller: RoleController })
        .when("/Administrator/Admin/EditRole/:Id", { templateUrl: "/Administrator/Admin/EditRole/", controller: RoleController })
        .otherwise("/");
}

myApp.config(RouteConfig);