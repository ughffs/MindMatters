import React from 'react';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import Main from './sections/main/Main';
import './style/common.css'

function App() {
  return (
    <Router>
      <Route exact path="/" component={Main} />
    </Router>
  );
}

export default App;
