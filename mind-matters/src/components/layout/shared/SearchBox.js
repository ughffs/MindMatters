import React from 'react';

const SearchBox = (props) => {
    return(
        <div style={searchBoxContainer}>
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
    borderRadius: '3px'
}

const searchBoxContainer = {
    display: 'flex',
}

export default SearchBox;
