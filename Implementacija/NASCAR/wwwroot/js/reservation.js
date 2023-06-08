
document.addEventListener("DOMContentLoaded", function () {
    $("#end_date").form - control({
        onSelect: function () {
            (this).change();
        }
    });

    $("#start_date").form - control({
        onSelect: function () {
            $(this).change();
        }
    });

    $('#start_date').on('change', function () {
        alert('Element ' + this.name + 'clicked');
        if (Model.DropDate != null && Model.PickUpDate > Model.DropDate) {
            let date1 = new DateTime(Model.PickUpDate);
            let date2 = new DateTime(Model.DropDate);

            Model.price = Math.ceil((date2.getTime() - date1.getTime()) / (1000 * 3600 * 24)) * Model.Vehicle.Price;
        }
    });

    $('#end_date').on('change', function () {
        if (Model.PickUpDate != null && Model.PickUpDate > Model.DropDate) {
            let date1 = new DateTime(Model.PickUpDate);
            let date2 = new DateTime(Model.DropDate);

            Model.price = Math.ceil((date2.getTime() - date1.getTime()) / (1000 * 3600 * 24)) * Model.Vehicle.Price;
        }
    });
});