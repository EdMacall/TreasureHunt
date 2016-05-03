namespace TreasureHunt.Controllers {

    export class AboutController {
        public message = 'Hello from the about page!';
    }


    export class ClueController {
        public message = 'Hello from the Clue Controller!';

        public clue;

        constructor(private $http: ng.IHttpService,
            private $stateParams: ng.ui.IStateParamsService,
            private $state: ng.ui.IStateService) {
            $http.get(`/api/clues/${$stateParams['id']}`)
                .then((response) => { this.clue = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class HomeController {
        public message = 'Hello from the Home Controller!';

        public hunts;

        constructor(private $http: ng.IHttpService,
            private $state: ng.ui.IStateService) {
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class HuntController {
        public message = 'Hello from the Treasure Hunt Controller!';

        public hunts;

        public hunt;

        public teams;

        public teamadd;

        constructor(private $http: ng.IHttpService,
            private $stateParams: ng.ui.IStateParamsService,
            private $state: ng.ui.IStateService) {
            $http.get(`/api/hunts/${$stateParams['id']}`)
                .then((response) => {
                    console.log(response);
                    this.hunt = response.data;
                })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...'); });

            this.teams = [
                { name: 'Rat', points: 7},
                { name: 'Snake', points: 3},
                { name: 'Dog', points: 9},
                { name: 'Python', points: 4 }
                { name: 'Mouse', points: 10 },
                { name: 'Cat', points: 7 },
                { name: 'Eagle', points: 6 },
                { name: 'Raven', points: 5 }
            ];

            $http.get(`/api/hunts/${$stateParams['id']}/teams`)
                //.then((response) => { this.teams = response.data; })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...'); })
        }

        public saveHunt(): void {
            this.$http.post('/api/hunts', this.hunt)
                .then((response) => {
                    this.$state.go('hunt');
                })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }

        public saveTeam(): void {
            this.$http.post(`/api/teams/${this.$stateParams['id']}`, this.teamadd)
                .then((response) => {
                    this.$http.get(`/api/huntteams/${this.$stateParams['id']}`)
                        .then((response) => { this.teams = response.data })
                        .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
                    this.$state.go('huntview');
                })
                .catch((response) => { console.log('Whitney Houston,  we have a save team problem...') })
        }
    }


    export class HuntsController {
        public message = 'Hello from the Treasure Hunts Controller!';

        public hunts;

        public searchparameter;

        // This controller needs to be modified to take a search string
        constructor(private $http: ng.IHttpService,
            private $state: ng.ui.IStateService) {
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class SecretController {
        public message = 'Hello from the Secret Controller!';

        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class oldHomeController {
        public message = 'Hello from the home page!';
    }


    export class oldHuntController {
        public message = 'Hello from the Hunt page!';

        public hunts;

        public huntadd;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            // TODO this.$http = $http ?
            // TODO getHunts(); ?
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }

        public saveHunt(): void {
            console.log("I ran");
            this.$http.post('/api/hunts', this.huntadd)
                .then((response) => {
                    // do we even need this anymore?
                    this.$state.go('hunt');
                    // do we even need that anymore?

                    this.$http.get('/api/hunts')
                        .then((response) => { this.hunts = response.data })
                        .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
                })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }

        /*
        public getHunts(): void {
                    this.$http.get('/api/hunts')
                        .then((response) => { this.hunts = response.data })
                        .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
        */
    }


    // do we even need this anymore?
    export class oldHuntAddController {
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
    // do we even need that anymore?


    export class oldHuntTeamsController {
        public message = 'Hello from the Hunt Teams page!';

        public hunts;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class oldHuntViewController {
        public message = 'Hello from the Hunt View page!';

        public hunt;

        public teams;

        public teamadd;

        constructor(private $http: ng.IHttpService,
            private $stateParams: ng.ui.IStateParamsService,
            private $state: ng.ui.IStateService) {
            $http.get(`/api/hunts/${$stateParams['id']}`)
                .then((response) => { this.hunt = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
            // $http.get(`/api/huntteams/${$stateParams['id']}`)
            // $http.get(`/api/hunts/${$stateParams['id']}`)
            $http.get(`/api/huntteams/${$stateParams['id']}`)
                .then((response) => { this.teams = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }

        public saveHunt(): void {
            this.$http.post('/api/hunts', this.hunt)
                .then((response) => {
                    this.$state.go('hunt');
                })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }

        public saveTeam(): void {
            // this.$http.post(`/api/teams/${this.$stateParams['id']}`, { name: this.teamadd })
            this.$http.post(`/api/teams/${this.$stateParams['id']}`, this.teamadd)
                .then((response) => {
                    this.$http.get(`/api/huntteams/${this.$stateParams['id']}`)
                        .then((response) => { this.teams = response.data })
                        .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
                    this.$state.go('huntview');
                    // This doesn't work
                    // this.teams.push(response.data);
                })
                .catch((response) => { console.log('Whitney Houston,  we have a save team problem...') })
        }
    }


    export class oldPlayController {
        public message = 'Hello from the PlayPage page!';

        public hunt;
        public team;
        public focusriddle;
        public riddles;
        public pickedRiddle;
        public answer;
        public submittedanswer;
        public teams;

        constructor(private $http: ng.IHttpService,
            private $stateParams: ng.ui.IStateParamsService,
            private $state: ng.ui.IStateService) {

            $http.get(`/api/teams/${$stateParams['id']}`)
                .then((response) => { this.team = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem in the play controllers teams get...') });
            $http.get(`/api/teamhunts/${$stateParams['id']}`)
                .then((response) => { this.hunt = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem in the play controllers teamhunts get...') });

            // The only riddles which should be returned are the ones that match this Hunt
            $http.get('/api/riddles')
                .then((response) => { this.riddles = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem in the play controllers riddles gets...') })

            // do we need this? or could the web page get the answer it needs from the next loader?
            // how to know which clue to get?
            $http.get('/api/riddle')
                .then((response) => { this.focusriddle = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem in the play controllers riddle get...') });

            ////  This doesn't work
            //for (let r in this.riddles) {
            //    if (r.isAnswered) {
            //        r.completed = "Completed";
            //        console.log("We have a completed.");
            //    }
            //}
        }

        public pickColor(pickedRiddle): void {
            this.focusriddle = pickedRiddle;
            // console.log(pickedRiddle);
        }

        public submitAnswer(): void {
            this.answer = this.submittedanswer;
            // console.log(pickedRiddle);
            this.$http.post(`/api/riddle/${this.$stateParams['id']}`, this.submittedanswer)
                .then((response) => {
                    this.$http.get(`/api/huntteams/${this.$stateParams['id']}`)
                        .then((response) => { this.teams = response.data })
                        .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
                    this.$state.go('huntview');

                })
                .catch((response) => { console.log('Whitney Houston,  we have a save team problem...') })
        }
    }


    // added 4/25/16
    export class oldPointController {
        public points;

        constructor(public $http: ng.IHttpService) {
            this.$http.get<any>('/api/Points')
                .then((response) => {
                    this.points = response.data;
                });
        }
    }


    export class oldRiddleController {
        public message = 'Hello from the Riddle page!';

        public riddleAdd;
        public riddles;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/riddles')
                .then((response) => { this.riddles = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
        public saveRiddle(): void {
            console.log("I ran");
            this.$http.post('/api/riddles', this.riddleAdd)
                .then((response) => {


                    this.$http.get('/api/riddles')
                        .then((response) => { this.riddles = response.data })
                        .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
                })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class oldTeamController {
        public message = 'Hello from the Team page!';

        public teams;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/teams')
                .then((response) => { this.teams = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }
}
