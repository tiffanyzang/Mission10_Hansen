import React from 'react';
import './App.css';
import Heading from './Header';
import BowlerList from './Bowling/BowlerList';

function App() {
  return (
    <div className="App">
      <Heading />
      <BowlerList />
    </div>
  );
}

export default App;
