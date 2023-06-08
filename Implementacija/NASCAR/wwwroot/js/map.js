function GetMap() {
    var map = new Microsoft.Maps.Map('#myMap', {
        credentials: 'AvkFGHkJnV4jnMnmPEuCQw7fYZEEp31UObtBBhtIxBcMHoi3dgt_i3tMLX7U3Ru9',
        center: new Microsoft.Maps.Location(43.8563, 18.4131),
        mapTypeId: Microsoft.Maps.MapTypeId.aerial,
        zoom: 8
    });
    infobox = new Microsoft.Maps.Infobox(map.getCenter(), {
        visible: false
    });
    infobox.setMap(map);

    var butmir = new Microsoft.Maps.Location(43.819246, 18.327324);
    var pinButmir = new Microsoft.Maps.Pushpin(butmir);
    pinButmir.metadata = {
        title: 'Sarajevo',
        description: 'Lokacija 1: Sarajevo, Butmir bb.'
    };

    Microsoft.Maps.Events.addHandler(pinButmir, 'click', pushpinClicked);
    map.entities.push(pinButmir);

    var tuzla = new Microsoft.Maps.Location(44.529169, 18.690747);
    var pinTuzla = new Microsoft.Maps.Pushpin(tuzla);
    pinTuzla.metadata = {
        title: "Tuzla",
        description: "Lokacija 2: Tuzla, Branilaca Tuzle bb."
    };

    Microsoft.Maps.Events.addHandler(pinTuzla, "click", pushpinClicked);
    map.entities.push(pinTuzla);

    var mostar = new Microsoft.Maps.Location(43.343809, 17.810127);
    var pinMostar = new Microsoft.Maps.Pushpin(mostar);
    pinMostar.metadata = {
        title: "Mostar",
        description: "Lokacija 3: Mostar, Stari Most Mostar bb."
    };

    Microsoft.Maps.Events.addHandler(pinMostar, "click", pushpinClicked);
    map.entities.push(pinMostar);


}


function makePins() {
    

   

}

function pushpinClicked(e) {
    if (e.target.metadata) {
        infobox.setOptions({
            location: e.target.getLocation(),
            title: e.target.metadata.title,
            description: e.target.metadata.description,
            visible: true
        });
    }
}