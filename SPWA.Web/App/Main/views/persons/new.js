(function () {
    angular.module('app').controller('spwa.views.person.new', [
        '$scope', '$modalInstance', 'abp.services.app.person',
        function ($scope, $modalInstance, personService) {
            var vm = this;
            vm.personDto = {};

            vm.save = function () {
                
                personService.addPerson(vm.personDto)
                    .success(function () {
                        abp.notify.info('保存成功!');
                        $modalInstance.close();
                    });
            };

            vm.cancel = function () {
               
                $modalInstance.dismiss();
            };
        }
    ]);
})();