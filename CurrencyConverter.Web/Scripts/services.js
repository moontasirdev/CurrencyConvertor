'use strict';

// Demonstrate how to register services
// In this case it is a simple value service.
angular.module('app.services', [])
    .service('restBackend', ['$http','$q', function($http, $q) {
        var self = this;
        var deferred = $q.defer();
        self.getExchangeRates = function() {
            $http.get(
                'http://localhost:58919/api/values',
                {
                    'Content-Type': 'application/json',
                    'Cache-Control': 'no-cache'
                }).success(
                function (data, status, headers, config) {
                    deferred.resolve({ status: 200, response: data });
                });
            return deferred.promise;
        };
    }])
    .value('version', '0.1');