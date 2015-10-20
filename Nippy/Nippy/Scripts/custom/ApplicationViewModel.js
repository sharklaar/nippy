var ViewModel = function() {
    var self = this;

    self.currentStep = ko.observable(0);

    self.nextStep = function() {
        self.currentStep(self.currentStep() + 1);
    };
    self.previousStep = function() {
        self.currentStep(self.currentStep() - 1);
    };

    return {
        nextStep: self.nextStep,
        previousStep: self.previousStep,
        currentStep: self.currentStep
    };
};

$(document).ready(function () {
    var viewModel = new ViewModel();
    ko.applyBindings(viewModel, $('#buttons').get(0));
});
