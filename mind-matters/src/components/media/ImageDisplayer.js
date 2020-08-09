import React from 'react';
import PropTypes from 'prop-types';
import 'components/media/ImageDisplayer.css';

const ImageDisplayer = (props) => {
    const imageDisplayer = {
        backgroundImage: `url(${props.image})`
    }

    return (
        <div style={imageDisplayer} className="image-displayer-container">
            
        </div>
    );
    
    
};



ImageDisplayer.propTypes = {
    image: PropTypes.string
}

export default ImageDisplayer;