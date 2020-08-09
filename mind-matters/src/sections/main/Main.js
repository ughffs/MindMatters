import React from 'react';
import Header from 'components/layout/main/Header';
import ImageDisplayer from 'components/media/ImageDisplayer';
import MindMattersBanner from 'images/mental-health.png';
import 'style/common.css'

const Main = (props) => {
    return(
        <React.Fragment>
            <div className="fragment-default-style">
                <Header />
                <div className="body-main">
                    <ImageDisplayer image={MindMattersBanner} /> 
                </div>            
            </div>
            <div className="fragment-default-style">
                
            </div>
        </React.Fragment>
    );
};

export default Main;