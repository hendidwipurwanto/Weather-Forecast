$(document).ready(function () {

    $.ajax({
        url: "/api/country/getallcountry", success: function (result) {
            console.log(result);
            for (var i = 0; i < result.length; i++) {
                $('#countryDDL').append('<option value=' + result[i].countryCode + '>' + result[i].name + '</option>');
            }
            $('#countryDDL').change(function (e) {
                $.ajax({
                    url: "/api/city/GetCityByCountryCode", data: { code: ''+ this.value +'' },
                    success: function (city) {
                        $('#cityDDL').empty()
                        $('#cityDDL').change(function (e) {

                            $.ajax({
                                    url: "/api/weather/GetWeatherByCity", data: { cityName: '' + this.value + '' },
                                success: function (result) {
                                    $('#cityName').text(result.location);
                                    $('#temp').html(result.temperaturInCelcius + '&#176;C');
                                    $('#skyCondition').text(result.skyCondition);
                                    $('#wind').text(result.wind);
                                    $('#visibility').text(result.visibility)
                                    $('#humidity').text(result.relativeHumidity)
                                    $('#pressure').text(result.pressure);
                                    $('#dateTime').text(result.time);
                                    console.log(result);
                                }
                            });

                            
                        });
                        for (var i = 0; i < result.length; i++) {
                            $('#cityDDL').append('<option value=' + city[i].name + '>' + city[i].name + '</option>');
                        }
                       
                    }
                });
            })
        }
    });

});