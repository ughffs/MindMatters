import React from 'react';
import { BrowserRouter as Link } from 'react-router-dom';
import './Header.css'
import logo from 'images/colour-logo-no-background.svg';

const Header = (props) => {
    return(
        <header className="header-style">
            <div className="header-container">
                <div className="header-left-container">
                    
                    <div className="header-menu-logo" style={ headerLeftLogo }></div>
                </div>
                <div className="header-menu-container">
                    <ul>
                        <li><a href="#">Home</a></li>
                        <li><a href="#">Services</a></li>
                        <li><a href="#">Help</a></li>
                    </ul>
                </div>
            </div>
        </header>
    );
};

// Style definitions inside of the component
const headerLeftLogo = {
    backgroundImage: `url(${ logo })`
};

export default Header;
