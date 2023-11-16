import { useState } from "react";

import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { library } from "@fortawesome/fontawesome-svg-core";
import {
  faMugHot,
  faGear,
  faUser,
  faXmark,
} from "@fortawesome/free-solid-svg-icons";
import Input from "../input/Input";
import Button from "../button/Button";

import styles from "./Login.module.scss";

library.add(faMugHot, faGear, faUser, faXmark);

function Login() {
  const [showLogin, setShowLogin] = useState(true);

  const toggleForm = () => {
    setShowLogin(!showLogin);
  };

  return (
    <div className={styles.login}>
      <div className={styles.container}>
        {showLogin ? (
          <form id="login">
            <div className={styles.data__container}>
              <h2>Login</h2>
              <Input placeholder="Email" type="email"/>
              <Input placeholder="Password" type="password" />
            </div>
            <div className={styles.submit}>
              <Button variant="primary" label="Login" />
              <span>Do not have an account?</span>
              <span className={styles.Link} onClick={toggleForm}>
                Create Account
              </span>
            </div>
          </form>
        ) : (
          <form id="signup">
            <div className={styles.data__container}>
              <h2>Signup</h2>
              <Input placeholder="Email" type="email" />
              <Input placeholder="Password" type="password" />
              <Input placeholder="Repeat Password" type="password" />
            </div>
            <div className={styles.submit}>
              <Button variant="primary" label="Signup" />
              <span>Already have an account?</span>
              <span className={styles.Link} onClick={toggleForm}>
                Login
              </span>
            </div>
          </form>
        )}
      </div>
    </div>
  );
}

export default Login;
