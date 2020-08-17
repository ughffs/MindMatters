import React from 'react';
import { useEffect, useState } from 'react';
import FeatureItem from 'components/layout/main/FeatureItem';
import PlaceholderImage from 'images/placeholder.jpg';

const FeaturePanel = (props) => {
  const [features, setFeatures] = useState([]);
  const [something, setSomething] = useState("Hello");
  
  // Use a hook here to make the api call (similar to componentDidMount())
  useEffect(() => {
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then(res => res.json())
      .then(json => setFeatures(json))
  }, [])

  // For demo purposes, grab the top 3 results from the json request
  let topFeatures = [...features].slice(0,3);
  //console.log(topFeatures);

  return (
        <div className="feature-panel">
          {topFeatures.map(feature => (
            <FeatureItem key={feature.id} image={PlaceholderImage} featureTitle={feature.title} featureBlurb={feature.body} />
          ))}
          
        </div>
  );
};

export default FeaturePanel;
