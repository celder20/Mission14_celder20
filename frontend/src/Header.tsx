import logo from "./dame-winner.jpg";

function Header(props: any) {
  return (
    <header className="row">
      <div className="col-5">
        <img src={logo} alt="Logo!"></img>
      </div>
      <div className="col">
        <h3>{props.slogan}</h3>
      </div>
    </header>
  );
}

export default Header;
