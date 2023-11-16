import styles from './Nav.module.scss'
import Logo from '../../assets/img/logo.png'

function Nav() {
    return (
        <div className={styles.nav}>
            <div className={styles.items}>
            <img src={Logo} alt='sysTrack'></img>
            <nav>
                <ul>
                    <li>My Profile</li>
                    <li>Computers</li>
                </ul>
            </nav>
            </div>
            <span>unknown@unknown</span>
        </div>
    )
}

export default Nav;