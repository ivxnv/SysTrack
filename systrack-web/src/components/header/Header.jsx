import { useState } from "react";
import { Link } from "react-router-dom";

import styles from "./Header.module.scss";
import Logo from "../../assets/img/logo.png";
import Button from "../button/Button";
import Login from "../login/Login";

function Header() {
  const [showLogin, setShowLogin] = useState(false);

  const toggleLogin = () => {
    setShowLogin(!showLogin);
  };

  return (
    <div>
      <header className={styles}>
        <Link to={"/"}>
          <div className={styles.logo}>
            <img src={Logo} alt="sysTrack" />
            <h1>sysTrack</h1>
          </div>
        </Link>
        <nav>
          <ul>
            <li onClick={toggleLogin}>Login</li>
            <Link to={"/new-room"}>
              <Button variant={"primary"} label={"Create Room"} />
            </Link>
          </ul>
        </nav>
      </header>

      {showLogin && <Login onClose={toggleLogin} />}
    </div>
  );
}

export default Header;
