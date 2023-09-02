import Test from "./components/Test";


function App() {
  const test = { id: 1, title: 'Test Props' }
  return (
    <div className="App">
      <Test test={test} />
    </div>
  );
}

export default App;
