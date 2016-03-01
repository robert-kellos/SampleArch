(function (angular) {
    'use strict';

    var controllers = angular.module('controllers', []);

    //#region HomeCtrl
    controllers.controller('HomeCtrl', ['$scope', function ($scope) {
        $scope.title = 'Home';
    }]);
    //#endregion

    //#region AboutCtrl
    controllers.controller('AboutCtrl', ['$scope', function ($scope) {
        $scope.title = 'About';
    }]);
    //#endregion

    //#region ePanelCtrl
    controllers.controller('ePanelCtrl', ['$scope', function ($scope) {
        $scope.title = 'ePanel';
    }]);
    //#endregion

    //#region SignOffCtrl
    controllers.controller('SignOffCtrl', ['$scope', function ($scope) {
        $scope.title = 'SignOff';
    }]);
    //#endregion

    //#region NavCtrl
    controllers.controller('NavCtrl', ['$scope', '$location',
        function ($scope, $location) {
            $scope.getClass = function (button) {
                var path = $location.path();
                if (path.indexOf(button) === 0) {
                    return 'active';
                } else {
                    return '';
                }
            };
        }]);
    //#endregion

    //#region LoginCtrl
    controllers.controller('LoginCtrl', ['$scope', '$safeApply', 'authService', '$rootScope', '$auth',
        function ($scope, $safeApply, authService, $rootScope, $auth) {
            $scope.userName = '';
            $scope.password = '';
            $scope.rememberMe = false;

            $scope.signIn = function () {
                $auth.login($scope.userName, $scope.password, $scope.rememberMe)
                    .then(function (data) {
                        $safeApply($scope, function () {
                            $rootScope.userName = data.userName;
                        });
                        authService.loginConfirmed({
                            user: data.userName
                        },
                            function (config) {
                                config.headers.Authorization = data.Authorization;
                                return config;
                            });
                    });
            };

            $scope.cancel = function () {
                authService.loginCanceled();
            };

        }]);
    //#endregion

    //#region LogsCtrl
    controllers.controller('LogsCtrl', ['$scope', '$safeApply', '$signalR',
        function ($scope, $safeApply, $signalR) {
            $scope.logs = [];

            var logsType = [];
            logsType['FATAL'] = 'alert alert-error repeat-item';
            logsType['ERROR'] = 'alert alert-error repeat-item';
            logsType['WARN'] = 'alert alert-info repeat-item';
            logsType['INFO'] = 'alert alert-success repeat-item';
            logsType['DEBUG'] = 'alert alert-info repeat-item';

            $signalR.$on('loggedEvent', function (e, loggedEvent) {
                $safeApply($scope, function () {
                    loggedEvent.class = logsType[loggedEvent.Level];
                    $scope.logs.splice(0, 0, loggedEvent);
                });
            });

            $scope.clearLogs = function () {
                $scope.logs.length = 0;
            };

        }]);
    //#endregion

})(window.angular);
