(function () {
    var app = angular.module('app');

    var controllerId = 'spwa.views.persons.index';
    app.controller(controllerId, [
        '$scope', '$modal', 'abp.services.app.person',
        function ($scope,$modal, personService) {
            var vm = this;

           // vm.localize = abp.localization.getSource('Source');

            vm.persons = [];


            function getPersons() {
                personService.getPersons().success(function(data) { vm.persons = data.persons; });
            };           
            getPersons();

            vm.getPersonCountText = function () {
                return abp.utils.formatString(App.localize('Xpersons'), vm.persons.length);
            };


            vm.openAddPersonModal = function () {
                var modalInstance = $modal.open({
                    templateUrl: '/App/Main/views/persons/new.cshtml',
                    controller: 'spwa.views.person.new as vm',
                    backdrop: 'static'
                });

                modalInstance.result.then(function () {
                    getPersons();
                });
            };
        }
    ]);
})();