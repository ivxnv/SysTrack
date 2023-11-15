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
  return (
    <div className={styles.login}>
      <div className={styles.container}>
        <form id="login">
          <h2>Login</h2>
          <div className={styles.data__container}>
            <Input placeholder="Username" />
            <Input placeholder="Password" type="password" />
          </div>
          <Button variant="primary" label="Login" />
          <span>Create Account</span>
        </form>
      </div>
    </div>
  );
}

export default Login;
