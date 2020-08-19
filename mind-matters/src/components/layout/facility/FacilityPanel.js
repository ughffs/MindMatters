import React from 'react';
import { useEffect, useState } from 'react';
import Facility from 'components/layout/facility/Facility';

const FacilityPanel = (props) => {

    const [facilities, setFacilities] = useState([]);


    let myHeaders = new Headers();
    myHeaders.append('Access-Control-Allow-Origin', '*');
        
    const fetchInit = {
        mode: 'cors',
        headers: myHeaders
    };


    // Use a hook here to make the api call
    useEffect(() => {
        fetch("/mindmatters.webapi/api/v1/facility")
        .then(res => res.json())
        .then(json => setFacilities(json))
    }, [])

    return(
        <div>

        </div>
    );
};

export default FacilityPanel;