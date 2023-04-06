import React from "react";
import logo from "./dame-winner.jpg";
import "./App.css";
import Header from "./Header";
import MovieList from "./movie/movieList";

function App() {
  return (
    <div className="App">
      <Header
        slogan="This picture to the left has nothing to do with movies but is simply a photo of my favorite player, Damian Lillard,
      hitting a game winning shot. #DAMETIME"
      />
      {/* Bring in the MovieList function to display on the web page */}
      <MovieList />
    </div>
  );
}

export default App;
