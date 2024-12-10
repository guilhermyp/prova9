import React from "react";
import {BrowserRouter, link, Route, Routes} 'from react-router-dom';
import alunocadastar from './pages/alunocadastar';

function App() {
  return (
    <div id="app">
      <h1>Projeto IMC</h1>
    </div>
  );
<Routes>
  <Route path ="/Alunos" element={<alunocadastar/>}/>
</Routes>

}

export default App;
