import styles from './Nav.module.scss'
import Logo from '../../assets/img/logo.png'

function Nav() {
    return (
        <div className={styles.nav}>
            <img src={Logo} alt='sysTrack'></img>
            <nav>

            </nav>
        </div>
    )
}

export default Nav;