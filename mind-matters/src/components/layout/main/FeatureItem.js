import React from 'react';

const FeatureItem = (props) => {
  const featureItemPicture = {
    backgroundImage: `url(${props.image})`
  }
    return(
      <div className="feature-item-container">
        <div className="feature-item-picture" style={featureItemPicture}>
        </div>
        <div className="feature-item-title">
          {props.featureTitle}
        </div>
        <div className="feature-item-blurb">
          {props.featureBlurb}
        </div>
        <div className="feature-item-actions">
          View
        </div>
      </div>
    );
};

export default FeatureItem;
