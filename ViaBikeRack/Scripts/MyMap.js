var map;
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 29.458525, lng: -98.523272 },
        zoom: 13
    });
}