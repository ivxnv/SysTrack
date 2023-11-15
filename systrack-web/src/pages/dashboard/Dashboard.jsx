import styles from "./Dashboard.module.scss";
import Nav from "../../components/nav/Nav";

function Dashboard() {
  return (
    <div className={styles.dashboard}>
      <Nav />
      <div className={styles.container}></div>
    </div>
  );
}

export default Dashboard;
