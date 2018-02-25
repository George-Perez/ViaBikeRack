var map;
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: {
            lat: 29.412965, lng: -98.528803
        },
        zoom: 12,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    });


    //bus stations
    var maryLouiseStation = {
        info: '<strong>MARY LOUISE STATION</strong><br>\
					Stop Number: 10203<br>\
					<a href="https://goo.gl/maps/jKNEDz4SyyH2">Get Directions</a>',
        lat: 29.46492,
        long: -98.526469
    };


    var madlaTransitCenterWestSide = {
        info: '<strong>MADLA TRANSIT CENTER (West Side)</strong><br>\
					Stop Number: 11346<br>\
					<a href="https://goo.gl/maps/jKNEDz4SyyH2">Get Directions</a>',
        lat: 29.350051,
        long: -98.532319
    };


    var gilletteAndRhoda = {
        info: '<strong>GILLETTE & RHODA</strong><br>\
					Stop Number: 15699<br>\
					<a href="https://goo.gl/maps/jKNEDz4SyyH2">Get Directions</a>',
        lat: 29.330229,
        long: -98.53734
    };

    var southZarzamoraAndLaredo = {
        info: '<strong>S. ZARZAMORA & LAREDO</strong><br>\
					Stop Number: 28336<br>\
					<a href="https://goo.gl/maps/jKNEDz4SyyH2">Get Directions</a>',
        lat: 29.412965,
        long: -98.528803
    };

    var locations = [
        [maryLouiseStation.info, maryLouiseStation.lat, maryLouiseStation.long, 0],
        [madlaTransitCenterWestSide.info, madlaTransitCenterWestSide.lat, madlaTransitCenterWestSide.long, 1],
        [gilletteAndRhoda.info, gilletteAndRhoda.lat, gilletteAndRhoda.long, 2],
        [southZarzamoraAndLaredo.info, southZarzamoraAndLaredo.lat, southZarzamoraAndLaredo.long, 3]
    ];


    var infowindow = new google.maps.InfoWindow({});

    var marker, i;

    for (i = 0; i < locations.length; i++) {
        marker = new google.maps.Marker({
            position: new google.maps.LatLng(locations[i][1], locations[i][2]),
            map: map
        });

        google.maps.event.addListener(marker, 'click', (function (marker, i) {
            return function () {
                infowindow.setContent(locations[i][0]);
                infowindow.open(map, marker);
            }
        })(marker, i));
    }



    //the two busses

    var infowindowbus16 = '<div style="width:260px; height:270px;">' + 'BUS: 16<br>\
                BUS ROUTE: 522<br />' + '<iframe src="http://localhost:51967/BikeRack/Details/10" style="width:250px; height:220px; border:9px;" scrolling="no"></iframe>' + '</div>';



    var infowindowbus23 = '<div style="width:260px; height:270px;">' + 'BUS: 23<br>\
                BUS ROUTE: 522<br />' + '<iframe src="http://localhost:51967/BikeRack/Details/11" style="width:250px; height:220px; border:9px;" scrolling="no"></iframe>' + '</div>';

    var bus16 = {
        info: infowindowbus16,
        lat: 29.406249,
        long: -98.529785,
    
    }

    var bus23 = {
        lat: 29.443808,
        long: -98.525063,
        info: infowindowbus23,
      

    }



    var busses = [
        [bus16.info, bus16.lat, bus16.long, 0],
        [bus23.info, bus23.lat, bus23.long, 1],
    ];

    for (i = 0; i < busses.length; i++) {
        marker = new google.maps.Marker({
            position: new google.maps.LatLng(busses[i][1], busses[i][2]),
            map: map,
            icon: {
                url: 'https://i.imgur.com/OQJY2jF.png',
                //size: new google.maps.Size(500, 500),
                origin: new google.maps.Point(0, 0),
                anchor: new google.maps.Point(25, 0),
                scaledSize: new google.maps.Size(50, 50),
                labelOrigin: new google.maps.Point(9, 8)
            },
        });

        google.maps.event.addListener(marker, 'click', (function (marker, i) {
            return function () {
                infowindow.setContent(busses[i][0]);
                infowindow.open(map, marker);
            }
        })(marker, i));
    }















    //var marker = new google.maps.Marker({
    //    position: {
    //        lat: 29.406249, lng: -98.529785
    //    },
    //    map: map,
    //    info: 'BUS: 16<br>\
    //            BUS ROUTE: 522<br>',
    //    icon: {
    //        url: 'https://i.imgur.com/OQJY2jF.png',
    //        //size: new google.maps.Size(500, 500),
    //        origin: new google.maps.Point(0, 0),
    //        anchor: new google.maps.Point(25, 0),
    //        scaledSize: new google.maps.Size(50, 50),
    //        labelOrigin: new google.maps.Point(9, 8)
    //    },

    //});

    //marker.addListener('click', function () {
    //    infowindow.open(map, marker);
    //});



    //var infowindow2 = new google.maps.InfoWindow({
    //    content: '<div style="width:260px; height:270px;">BUS: 23<br>\
    //            BUS ROUTE: 522<br /><iframe src="http://localhost:51967/BikeRack/Details/10" style="width:250px; height:220px; border:9px;" scrolling="no"></iframe></div>'
    //});

    //var marker = new google.maps.Marker({
    //    position: {
    //      lat: 29.443808, lng: -98.525063
    //    },
    //    map: map,
    //    info: 'BUS: 23<br>\
    //            BUS ROUTE: 522<br>',
    //    icon: {
    //        url: 'https://i.imgur.com/OQJY2jF.png',
    //        //size: new google.maps.Size(500, 500),
    //        origin: new google.maps.Point(0, 0),
    //        anchor: new google.maps.Point(25, 0),
    //        scaledSize: new google.maps.Size(50, 50),
    //        labelOrigin: new google.maps.Point(9, 8)
    //    },

    //});





}