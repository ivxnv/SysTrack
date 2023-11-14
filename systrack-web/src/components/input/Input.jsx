import styles from "./Input.module.scss";

function Input({ placeholder, type }) {
  return <input className={styles} placeholder={placeholder} type={type} />;
}

export default Input;
