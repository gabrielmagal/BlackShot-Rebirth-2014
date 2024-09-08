window.ShowToastr = (type, message) => {

    toastr.options.toastClass = "toastr";
    toastr.options.closeButton = true;
    toastr.options.progressBar = true;
    toastr.options.preventDuplicates = true;
    toastr.options.timeOut = 10000;
    toastr.options.positionClass = "toast-center";


    if (type === "success") {
        toastr.success(message, "Realizado com sucesso.", toastr.options);
    }
    if (type === "error") {
        toastr.error(message, "Falha no processo.", toastr.options);
    }
};
