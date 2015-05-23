
function RoleController($scope, $http, $window, $routeParams) {
    
    var successCallback = function(data) {
        if (data.Success) {
            alert("Role Created Successfully");
            $window.history.back();
        } 
    }
    var errorCallback = function(data) {
        if (!data.Success) {
            alert("Cannot create role");
        }
    }

    $scope.submit = function() {
        $http({
            method: 'POST',
            url: "Administrator/Admin/CreateRole/",
            data: $scope.roleVM
        }).success(successCallback).error(errorCallback);
    }
    $scope.clear = function () {
        $scope.roleVM = null;
    }

  
    var test = function(data) {
        //var data = [{ContactName:"Khalid",ContactTitle:"Lol"}];
        
        debugger;
        jQuery("#tblRoleList").kendoGrid({
            dataSource: data,
            height: 550,
            
            sortable: true,
            pageable: {
                refresh: true,
                pageSizes: true,
                buttonCount: 5
            },
            columns: [{
                field: "RoleName",
                title: "Role Name",
            }, {
                field: "RoleResponsibility",
                title: "Role Responsibility"
            },
               {
                   width: 60,
                   field: "Id",
                   title: "Edit",
                   filterable: false,
                   sortable: false,
                   template: function (dataItem) {
                       if (dataItem != null) {
                           return "<span><a href=\#/Administrator/Admin/EditRole/" + dataItem.Id + "\> <i class='glyphicon glyphicon-edit'></i></a></span>";
                       }
                   }
               }
            ]
        });
    }
    

    $http({
        method: 'GET',
        url: "Administrator/Admin/GetRoleList/"
    }).success(test);
    var test2 = function (data) {
        $scope.roleVM = data;
    }
    if ($routeParams.Id>0) {
        $http({
            method: 'GET',
            url: "/Administrator/Admin/GetRoleById/"+$routeParams.Id
        }).success(test2);
       
    }

}