import logo from './logo.svg';
import './App.css';
import axios from 'axios';

function App() {

  const getData = () => {
    axios.get('https://localhost:7082/')
    .then((response) => {
      console.log(response.data);
    })
  }

  getData();

  return (
    <div className="App">
      
    </div>
  );
}

export default App;
