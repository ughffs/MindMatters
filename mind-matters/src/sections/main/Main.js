import React from 'react';
import Header from 'components/layout/main/Header';
import ImageDisplayer from 'components/media/ImageDisplayer';
import BlueImage from 'images/blue-background.jpg'
import SearchBox from 'components/layout/shared/SearchBox';
import 'style/common.css'

const Main = (props) => {
    return(
        <React.Fragment>
            <div className="fragment-default-style">
                <Header />
                <div className="body-main" style={customBodyStyle}>
                    <div className="search-panel" style={searchPanelWithBgImage}>
                      <div className="search-container">
                        <div className="search-header">
                          <div className="search-heading">
                                MindMatters.community
                            </div>            
                            <div className="subtle-heading">
                              <span class="bold-text">You are not alone.</span>
                            </div>
                            <div className="subtle-heading">
                              Find Mental Health Services near you
                            </div>
                        </div>
                        <SearchBox className="home-search-box" />
                      </div>
                    </div>
                </div>            
            </div>
            <div className="fragment-default-style">
                
            </div>
        </React.Fragment>
    );
};

const searchPanelWithBgImage = {
    width: '100%',
    backgroundSize: 'cover',
    backgroundPosition: 'center',
    backgroundImage: `linear-gradient(rgba(0, 0, 0, 0.4), rgba(0, 0, 0, 0.4)), url(${BlueImage})`
}

const customBodyStyle = {
    alignItems: 'start'
}

export default Main;
