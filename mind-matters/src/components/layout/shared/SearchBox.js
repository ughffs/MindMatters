import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faSearch } from '@fortawesome/free-solid-svg-icons';

const SearchBox = (props) => {
    return(
        <div style={searchBoxContainer}>
            <div className="search-icon-container">
              <FontAwesomeIcon icon={faSearch} />
            </div>
            <input 
                className={props.className}
                style={inputBoxStyle}
                type="text"
                placeholder="Search term..."
            />
        </div>
    );
};

const inputBoxStyle = {
    flex: '1',
    border: 'none',
    padding: '5px',
    backgroundColor: 'white',
    borderRadius: '0 3px 3px 0'
}

const searchBoxContainer = {
    display: 'flex',
    flexDirection: 'row'
}

export default SearchBox;
