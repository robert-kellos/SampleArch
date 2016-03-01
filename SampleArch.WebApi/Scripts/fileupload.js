(function () {
    'use strict';

    //angular
    //    .module('fileUpload')
    //    .controller('UploadCtrl', UploadCtrl);

    //UploadCtrl.$inject = ['$location', '$upload'];

    //function UploadCtrl($location, $upload) {
    //    /* jshint validthis:true */
    //    var vm = this;
    //    vm.title = 'UploadCtrl';

    //    vm.onFileSelect = function ($files, user) {
    //        //$files: an array of files selected, each file has name, size, and type.
    //        for (var i = 0; i < $files.length; i++) {
    //            var file = $files[i];
    //            vm.upload = $upload.upload({
    //                url: 'Helpers/UploadHandler.ashx',
    //                data: { name: user.Name },
    //                file: file, // or list of files ($files) for html5 only
    //            }).progress(function (evt) {
    //                //console.log('percent: ' + parseInt(100.0 * evt.loaded / evt.total));
    //            }).success(function (data, status, headers, config) {
    //                alert('Uploaded successfully ' + file.name);
    //            }).error(function (err) {
    //                alert('Error occurred during upload');
    //            });
    //        }
    //    };

    //};

    //inject angular file upload directives and services.
    var app = angular.module('dvs', ['ngFileUpload']);

    app.controller('UploadCtrl', function ($scope, Upload, $timeout) {
        $scope.uploadCtrl = function (file, errFiles) {
            $scope.f = file;
            $scope.errFile = errFiles && errFiles[0];
            if (file) {
                file.upload = Upload.upload({
                    url: 'Helpers/UploadHandler.ashx',//'https://angular-file-upload-cors-srv.appspot.com/upload',
                    data: { file: file }
                });

                file.upload.then(function (response) {
                    $timeout(function () {
                        file.result = response.data;
                    });
                }, function (response) {
                    if (response.status > 0)
                        $scope.errorMsg = response.status + ': ' + response.data;
                }, function (evt) {
                    file.progress = Math.min(100, parseInt(100.0 *
                        evt.loaded / evt.total));
                });
            }
        }
    }
    );

})();

