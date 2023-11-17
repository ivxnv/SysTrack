import { useState } from "react";

import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { library } from "@fortawesome/fontawesome-svg-core";
import {
  faMugHot,
  faGear,
  faUser,
  faKey,
  faXmark,
} from "@fortawesome/free-solid-svg-icons";
import Input from "../input/Input";
import Button from "../button/Button";

import styles from "./Login.module.scss";

library.add(faMugHot, faGear, faUser, faKey, faXmark);

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
              <div className={styles.input__container}>
                <FontAwesomeIcon
                  icon="user"
                  className={styles.fa}
                ></FontAwesomeIcon>
                <Input placeholder="Email" type="email" />
              </div>
              <div className={styles.input__container}>
              <FontAwesomeIcon
                  icon="key"
                  className={styles.fa}
                ></FontAwesomeIcon>
              <Input placeholder="Password" type="password" />
              </div>
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
              <div className={styles.input__container}>
              <FontAwesomeIcon
                  icon="user"
                  className={styles.fa}
                ></FontAwesomeIcon>
              <Input placeholder="Email" type="email" />
              </div>
              <div className={styles.input__container}>
              <FontAwesomeIcon
                  icon="key"
                  className={styles.fa}
                ></FontAwesomeIcon>
              <Input placeholder="Password" type="password" />
              </div>
              <div className={styles.input__container}>
              <FontAwesomeIcon
                  icon="key"
                  className={styles.fa}
                ></FontAwesomeIcon>
              <Input placeholder="Repeat Password" type="password" />
              </div>
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
