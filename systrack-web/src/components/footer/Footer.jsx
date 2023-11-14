import styles from "./Footer.module.scss";
import Diconium from "../../assets/img/dic.png";

function Footer() {
  return (
    <footer className={styles}>
      <div className={styles.footer__menu}>
        <div className={styles.footer__menu__container}>
          <a href="https://weare.diconium.com/de/">
            <img src={Diconium} alt="diconium"></img>
          </a>
          <ul>
            Product
            <li>Start new game</li>
            <li>FAQs</li>
          </ul>
          <ul>
            Connect
            <li>Contact us</li>
            <li>What is planning poker?</li>
          </ul>
          <ul>
            Legal
            <li>Imprint</li>
            <li>Cookie policy</li>
          </ul>
        </div>
        <span></span>
      </div>
      <span>©2023 diconium GmbH</span>
    </footer>
  );
}

export default Footer;
