import React from 'react';
import FeatureItem from 'components/layout/main/FeatureItem';
import PlaceholderImage from 'images/placeholder.jpg';

const FeaturePanel = (props) => {
  return (
        <div className="feature-panel">
          <FeatureItem image={PlaceholderImage} featureTitle="Something here" featureBlurb="This is some random blurb that will show"/>
          <FeatureItem image={PlaceholderImage} featureTitle="Something else here" featureBlurb="This is some random blurb that will show"/>
          <FeatureItem image={PlaceholderImage} featureTitle="Another thing here" featureBlurb="This is some other random blurb that will show"/>
        </div>
  );
};

export default FeaturePanel;
