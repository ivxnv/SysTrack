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

function Login({ onClose }) {
  return (
    <div className={styles.login}>
      <div className={styles.container}>
        <FontAwesomeIcon className={styles.fa} onClick={onClose} icon="xmark" />
        <form id="login">
          <h2>Login</h2>
          <Input placeholder="Username" />
          <Input placeholder="Password" type="password" />
          <Button variant="primary" label="Login" />
          <span>Create Account</span>
        </form>
      </div>
    </div>
  );
}

export default Login;
