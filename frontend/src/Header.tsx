import logo from './bowling.png';
function Header() {
  return (
    <header className="row navbar navbar-dark bg-light">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1>Bowling League Data</h1>
      </div>
    </header>
  );
}

export default Header;
