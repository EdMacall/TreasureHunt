namespace TreasureHunt {

    angular.module('TreasureHunt', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: TreasureHunt.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('clue', {
                url: '/clue/:id',
                templateUrl: '/ngApp/views/clue.html',
                controller: TreasureHunt.Controllers.ClueController,
                controllerAs: 'controller'
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: TreasureHunt.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            })
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: TreasureHunt.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('hunt', {
                url: '/hunt/:id',
                templateUrl: '/ngApp/views/hunt.html',
                controller: TreasureHunt.Controllers.HuntController,
                controllerAs: 'controller'
            })
            .state('hunts', {
                url: '/hunts',
                templateUrl: '/ngApp/views/hunts.html',
                controller: TreasureHunt.Controllers.HuntsController,
                controllerAs: 'controller'
            })
            .state('jointeam', {
                url: '/jointeam/:id',
                templateUrl: '/ngApp/views/jointeam.html',
                controller: TreasureHunt.Controllers.joinTeamController,
                controllerAs: 'controller'
            })
            .state('login', {
                url: '/login',
                templateUrl: '/ngApp/views/login.html',
                controller: TreasureHunt.Controllers.LoginController,
                controllerAs: 'controller'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            })
            .state('register', {
                url: '/register',
                templateUrl: '/ngApp/views/register.html',
                controller: TreasureHunt.Controllers.RegisterController,
                controllerAs: 'controller'
            })
            .state('secret', {
                url: '/secret',
                templateUrl: '/ngApp/views/secret.html',
                controller: TreasureHunt.Controllers.SecretController,
                controllerAs: 'controller'
            })
            .state('test', {
                url: '/test',
                templateUrl: '/ngApp/views/test.html',
                controller: TreasureHunt.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('oldhome', {
                url: '/oldhome',
                templateUrl: '/ngApp/views/old/oldhome.html',
                controller: TreasureHunt.Controllers.oldHomeController,
                controllerAs: 'controller'
            })
            .state('oldhunt', {
                url: '/oldhunt',
                templateUrl: '/ngApp/views/old/oldhunt.html',
                controller: TreasureHunt.Controllers.oldHuntController,
                controllerAs: 'controller'
            })
            .state('oldhuntadd', {
                url: '/oldhuntadd',
                templateUrl: '/ngApp/views/old/oldhuntadd.html',
                controller: TreasureHunt.Controllers.oldHuntAddController,
                controllerAs: 'controller'
            })
            .state('oldhuntteams', {
                url: '/oldhuntteams',
                templateUrl: '/ngApp/views/old/oldhuntteams.html',
                controller: TreasureHunt.Controllers.oldHuntTeamsController,
                controllerAs: 'controller'
            })
            .state('oldhuntview', {
                url: '/oldhuntview/:id',
                templateUrl: '/ngApp/views/old/oldhuntview.html',
                controller: TreasureHunt.Controllers.oldHuntViewController,
                controllerAs: 'controller'
            })
            .state('oldplay', {
                url: '/oldplay',
                templateUrl: '/ngApp/views/old/oldplay.html',
                controller: TreasureHunt.Controllers.oldRiddleController,
                controllerAs: 'controller'
            })
            .state('oldplaypage', {
                url: '/oldplay/:id',
                templateUrl: '/ngApp/views/old/oldplay.html',
                controller: TreasureHunt.Controllers.oldPlayController,
                controllerAs: 'controller'
            })
            .state('oldpoint', {
                url: '/oldpoint',
                templateUrl: '/ngApp/views/old/oldpoint.html',
                controller: TreasureHunt.Controllers.oldPointController,
                controllerAs: 'controller'
            })
            .state('oldriddle', {
                url: '/oldriddle',
                templateUrl: '/ngApp/views/old/oldriddle.html',
                controller: TreasureHunt.Controllers.oldRiddleController,
                controllerAs: 'controller'
            })
            .state('oldteam', {
                url: '/oldteam',
                templateUrl: '/ngApp/views/old/oldteam.html',
                controller: TreasureHunt.Controllers.oldTeamController,
                controllerAs: 'controller'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

    
    angular.module('TreasureHunt').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('TreasureHunt').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });

    

}
