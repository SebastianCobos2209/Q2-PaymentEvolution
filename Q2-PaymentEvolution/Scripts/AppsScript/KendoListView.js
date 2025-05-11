function initializeKendoViewList() {
    $("#appsCardView").kendoListView({
        template: kendo.template($("#appCardTemplate").html()),
        dataSource: {
            transport: {
                read: {
                    url: $("#appsCardView").data("url"),
                    dataType: "json"
                }
            },
            pageSize: 10
        },
        scrollable: {
            virtual: false,
            direction: "horizontal"
        }
    });
}