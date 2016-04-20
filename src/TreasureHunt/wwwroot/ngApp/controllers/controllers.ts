namespace TreasureHunt.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

    export class TeamController {
        public message = 'Hello from the Team page!';

        public teams;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/teams')
                .then((response) => { this.teams = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class HuntController {
        public message = 'Hello from the Hunt page!';

        public hunts;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class AddHuntController {
        public message = 'Hello from the Add Hunt page!';

        public hunt;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) { }

        public saveHunt(): void {
            this.$http.post('/api/hunts', this.hunt)
                .then((response) => {
                    this.$state.go('hunt');
                })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class HuntViewController {
        public message = 'Hello from the Hunt View page!';

        public hunt;

        public teams;

        constructor(private $http: ng.IHttpService,
                    private $stateParams: ng.ui.IStateParamsService,
                    private $state: ng.ui.IStateService) {
            $http.get(`/api/hunts/${$stateParams['id']}`)
                .then((response) => this.hunt = response.data)
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
                //$http.get(`/api/huntteams/${$stateParams['id']}`)
            $http.get(`/api/hunts/${$stateParams['id']}`)
                .then((response) =>
                { this.teams = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }

        public saveHunt(): void {
            this.$http.post('/api/hunts', this.hunt)
                .then((response) => {
                    this.$state.go('hunt');
                })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class HuntTeamsController {
        public message = 'Hello from the Hunt Teams page!';

        public hunts;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class RiddleController {
        public message = 'Hello from the Riddle page!';

        public riddles;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/riddles')
                .then((response) => { this.riddles = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }

}
