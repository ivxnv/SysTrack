import styles from "./Button.module.scss";

function Button({ variant, label }) {
  let buttonClass = "";

  if (variant === "primary") {
    buttonClass = styles.Primary;
  } else if (variant === "secondary") {
    buttonClass = styles.Secondary;
  }
  return <button className={buttonClass}>{label}</button>;
}

export default Button;
